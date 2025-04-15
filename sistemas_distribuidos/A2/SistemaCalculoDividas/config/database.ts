import env from '#start/env'
import { defineConfig } from '@adonisjs/lucid'

const isTestEnv = env.get('NODE_ENV') === 'test'

const dbConfig = defineConfig({
  connection: isTestEnv ? 'test' : env.get('DB_CONNECTION') || 'write',
  connections: {
    write: {
      client: 'pg',
      connection: {
        host: 'postgres-master',
        port: 5432,
        user: 'postgres',
        password: 'postgres',
        database: 'appdb',
      },
      migrations: {
        naturalSort: true,
        paths: ['database/migrations'],
      },
    },

    read: {
      client: 'pg',
      connection: {
        host: 'postgres-slave-1',
        port: 5432,
        user: 'postgres',
        password: 'postgres',
        database: 'appdb',
      },
    },
    test: {
      client: 'sqlite3',
      connection: {
        filename: env.get('DB_DATABASE', './tmp/dev.sqlite3'),
      },
      useNullAsDefault: true,
      migrations: {
        naturalSort: true,
      },
      debug: false,
    },
  },
})

export default dbConfig
