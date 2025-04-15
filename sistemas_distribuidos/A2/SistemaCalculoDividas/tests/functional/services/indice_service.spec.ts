import Selic from '#models/selic'
import { IndiceService } from '#services/indice_service'
import { test } from '@japa/runner'

test.group('IndiceService', (group) => {
  group.teardown(async () => {
    await Selic.query().delete()
  })

  test('should query Selic', async ({ assert }) => {
    const indiceService = new IndiceService()
    const registros = await indiceService.querySelic()

    assert.notEqual(registros.length, 0)
    assert.equal(registros[0].data, '08/1986')
    assert.equal(registros[1].data, '09/1986')
  })

  test('should not insert if record already exists', async ({ assert }) => {
    await Selic.create({
      mesAno: '01/2010',
      variacao: 8.65,
    })

    const indiceService = new IndiceService()
    const indices = await indiceService.querySelic()
    indiceService.create(indices)

    const registros = await Selic.all()

    assert.notEqual(registros.length, 0)
  })
})
