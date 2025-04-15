import Selic from '#models/selic'
import BaseQuery from './base_query.js'
import { CalcularDividaParams } from '../dtos/params/calcular_divida_params.js'
import { ResultadoCalculo } from '../dtos/result/calculo_result_dto.js'

export default class CalcularDividaSelicQuery extends BaseQuery {
  constructor() {
    super('read')
  }
  public static async executar({
    valorInicial,
    dataInicio,
    dataFim,
  }: CalcularDividaParams): Promise<ResultadoCalculo[]> {
    const resultados: ResultadoCalculo[] = []
    const dataCorrigida = dataInicio.plus({ days: 30 })

    let acumulado = 0

    const dataInicioFormatada = dataCorrigida.startOf('month').toSQLDate()
    const dataFimFormatada = dataFim.endOf('month').toSQLDate()

    if (!dataInicioFormatada || !dataFimFormatada) {
      throw new Error('Datas inválidas para consulta')
    }

    const indices = await Selic.query()
      .whereRaw("to_date(mes_ano, 'MM/YYYY') BETWEEN ? AND ?", [
        dataInicioFormatada,
        dataFimFormatada,
      ])
      .orderByRaw("to_date(mes_ano, 'MM/YYYY') ASC")

    for (const indice of indices) {
      const valorAtualizacao = (valorInicial + acumulado) * (indice.variacao / 100)
      acumulado += valorAtualizacao

      resultados.push({
        mesAno: indice.mesAno,
        variacao: indice.variacao,
        valorAtualizacao: Number.parseFloat(valorAtualizacao.toFixed(2)),
        valorAtualizacaoAcumulado: Number.parseFloat(acumulado.toFixed(2)),
        valorReajustado: Number.parseFloat((valorInicial + acumulado).toFixed(2)),
      })
    }

    return resultados
  }
}
