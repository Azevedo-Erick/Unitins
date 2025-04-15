import { IndiceService } from '#services/indice_service'
import { inject } from '@adonisjs/core'
import { BaseCommand } from '@adonisjs/core/ace'
import type { CommandOptions } from '@adonisjs/core/types/ace'

@inject()
export default class ConsultarIndices extends BaseCommand {
  static commandName = 'consultar:indices'
  public static description = 'Consulta os índices IGP-DI e Selic e armazena no banco de dados'

  static options: CommandOptions = {}

  async run(indiceService: IndiceService) {
    const data = await indiceService.querySelic()
    indiceService.create(data)
    this.logger.info('Hello world from "ConsultarIndices"')
  }
}
