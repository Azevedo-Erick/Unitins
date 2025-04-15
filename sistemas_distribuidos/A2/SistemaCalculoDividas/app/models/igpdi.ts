import { DateTime } from 'luxon'
import { BaseModel, column } from '@adonisjs/lucid/orm'

export default class Igpdi extends BaseModel {
  static table = 'igpdi'

  @column({ isPrimary: true })
  declare id: number
  @column({
    columnName: 'mes_ano',
  })
  public mesAno: string = ''

  @column()
  public variacao: number = 0.0

  @column.dateTime({ autoCreate: true })
  declare createdAt: DateTime

  @column.dateTime({ autoCreate: true, autoUpdate: true })
  declare updatedAt: DateTime
}
