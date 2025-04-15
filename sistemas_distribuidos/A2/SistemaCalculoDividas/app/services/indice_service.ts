import Selic from '#models/selic'
import { Indice } from '../types/indice.js'

export class IndiceService {
  public async create(data: Indice[]) {
    data.forEach(async (e) => {
      const registro = await Selic.findBy('mes_ano', e.data)
      if (!registro) {
        Selic.create({
          mesAno: e.data,
          variacao: e.valor,
        })
      }
    })
    return true
  }
  public async querySelic() {
    const apiUrl = 'https://api.bcb.gov.br/dados/serie/bcdata.sgs.4390/dados?formato=json'

    const response = await fetch(apiUrl)
    const jsonData = (await response.json()) as Indice[]
    return jsonData.map((e) => {
      const mesAno = `${e.data.split('/')[1]}/${e.data.split('/')[2]}`
      e.data = mesAno
      return e
    })
  }
}
