import db from '@adonisjs/lucid/services/db'

export default class BaseQuery {
  protected connectionName: string

  constructor(connectionName: string) {
    this.connectionName = connectionName
  }

  protected table(tableName: string) {
    return db.connection(this.connectionName).from(tableName)
  }
}
