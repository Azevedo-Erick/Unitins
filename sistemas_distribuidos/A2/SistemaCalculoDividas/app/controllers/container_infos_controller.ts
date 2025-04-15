// import type { HttpContext } from '@adonisjs/core/http'

import { HttpContext } from '@adonisjs/core/http'
import { hostname, networkInterfaces } from 'node:os'
export default class ContainerInfosController {
  public async show({ view }: HttpContext) {
    const nets = networkInterfaces()
    let containerIp = ''

    for (const name of Object.keys(nets)) {
      const netInfo = nets[name]
      if (!netInfo) continue

      for (const net of netInfo) {
        if (net.family === 'IPv4' && !net.internal) {
          containerIp = net.address
          break
        }
      }

      if (containerIp) break
    }

    return view.render('pages/info/containerInfo', {
      containerIp: containerIp,
      hostname: hostname(),
    })
  }
}
