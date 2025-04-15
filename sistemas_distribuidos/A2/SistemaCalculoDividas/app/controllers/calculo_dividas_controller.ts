// import type { HttpContext } from '@adonisjs/core/http'

import { HttpContext } from '@adonisjs/core/http'
import CalcularDividaSelicQuery from '../queries/calculo_divida_selic_query.js'

export default class CalculoDividasController {
  public async form({ view }: HttpContext) {
    return view.render('pages/divida/form')
  }

  public async calcular({ request, view }: HttpContext) {
    const valor = request.input('valor')
    const dataInicio = request.input('data_inicio')
    const dataFim = request.input('data_fim')

    const resultado = await CalcularDividaSelicQuery.executar({
      dataFim: dataFim,
      dataInicio: dataInicio,
      valorInicial: valor,
    })

    return view.render('pages/divida/resultado', { resultado })
  }
}
