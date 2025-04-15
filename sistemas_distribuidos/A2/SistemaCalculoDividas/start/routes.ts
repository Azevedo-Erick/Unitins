const CalculoDividasController = () => import('#controllers/calculo_dividas_controller')
const ContainerInfosController = () => import('#controllers/container_infos_controller')
const MetricsController = () => import('#controllers/metrics_controller')
import router from '@adonisjs/core/services/router'

router.get('/calculo-divida', [CalculoDividasController, 'form'])
router.post('/calculo-divida', [CalculoDividasController, 'calcular'])
router.get('/container-info', [ContainerInfosController, 'show'])
router.get('/metrics', [MetricsController, 'handle'])
router.on('/').render('pages/home')
