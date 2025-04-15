#!/bin/bash
set -e

# Faz o backup apenas se o data dir estiver vazio
if [ -z "$(ls -A /var/lib/postgresql/data)" ]; then
  echo "Realizando base backup do master..."

  PGPASSWORD=replicatorpass pg_basebackup \
    -h postgres-master \
    -D /var/lib/postgresql/data \
    -U replicator \
    -Fp -Xs -P -R
fi

# Garante que o postgres rode normalmente
exec docker-entrypoint.sh postgres
