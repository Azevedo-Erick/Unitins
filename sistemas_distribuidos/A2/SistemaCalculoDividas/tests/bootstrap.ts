import { assert } from '@japa/assert'
import app from '@adonisjs/core/services/app'
import type { Config } from '@japa/runner/types'
import { pluginAdonisJS } from '@japa/plugin-adonisjs'
import testUtils from '@adonisjs/core/services/test_utils'
import { existsSync, mkdirSync } from 'node:fs'
import { exit } from 'node:process'
import db from '@adonisjs/lucid/services/db'

/**
 * This file is imported by the "bin/test.ts" entrypoint file
 */

/**
 * Configure Japa plugins in the plugins array.
 * Learn more - https://japa.dev/docs/runner-config#plugins-optional
 */
export const plugins: Config['plugins'] = [assert(), pluginAdonisJS(app)]

/**
 * Configure lifecycle function to run before and after all the
 * tests.
 *
 * The setup functions are executed before all the tests
 * The teardown functions are executed after all the tests
 */
export const runnerHooks: Required<Pick<Config, 'setup' | 'teardown'>> = {
  setup: [
    async () => {
      if (!existsSync('./tmp')) {
        mkdirSync('./tmp')
      }
      try {
        await testUtils.db().migrate()
      } catch (e) {
        console.log(e)
        exit(1)
      }
    },
  ],
  teardown: [
    async () => {
      await testUtils.db().truncate()
      await db.manager.closeAll()
    },
  ],
}

/**
 * Configure suites by tapping into the test suite instance.
 * Learn more - https://japa.dev/docs/test-suites#lifecycle-hooks
 */
export const configureSuite: Config['configureSuite'] = (suite) => {
  if (['browser', 'functional', 'e2e', 'integration'].includes(suite.name)) {
    return suite.setup(() => testUtils.httpServer().start())
  }
}
