FROM node:22-alpine AS base

WORKDIR /app

# Etapa de dependências (dev + prod)
FROM base AS deps
COPY package.json package-lock.json ./
RUN npm ci

# Etapa de dependências para produção
FROM base AS production-deps
COPY package.json package-lock.json ./
RUN npm ci --omit=dev

# Etapa de build
FROM base AS build
COPY --from=deps /app/node_modules /app/node_modules
COPY . .
RUN node ace build

# Etapa final para produção
FROM base
ENV NODE_ENV=production
WORKDIR /app

COPY --from=production-deps /app/node_modules /app/node_modules
COPY --from=build /app/build /app/build
COPY --from=build /app/config /app/config
COPY --from=build /app/public /app/public
COPY --from=build /app/start /app/start
COPY --from=build /app/.env /app/.env

EXPOSE 3333
CMD ["node", "build/bin/server.js"]

