import { HttpContext } from '@adonisjs/core/http'
import client from 'prom-client'
const collectDefaultMetrics = client.collectDefaultMetrics
collectDefaultMetrics()
export default class MetricsController {
  public async handle({ response }: HttpContext) {
    response.header('Content-Type', client.register.contentType)
    response.send(await client.register.metrics())
  }
}
