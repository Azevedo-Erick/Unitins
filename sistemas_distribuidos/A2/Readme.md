[AdonisJs-Prometheus](https://github.com/Julien-R44/adonisjs-prometheus)

#Notes
Como você está rodando AdonisJS, Redis, PostgreSQL e Prometheus localmente e está testando, o mais prático é usar:
docker-compose up -d --scale app=3
Isso já ativa o balanceamento round-robin automático pelo Traefik, sem precisar migrar pro Swarm.

