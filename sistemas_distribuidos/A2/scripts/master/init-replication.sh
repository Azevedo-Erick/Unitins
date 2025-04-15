#!/bin/bash
set -e

echo "host replication all 0.0.0.0/0 trust" >> "$PGDATA/pg_hba.conf"

cat >> "$PGDATA/postgresql.conf" <<EOF
wal_level = replica
max_wal_senders = 10
wal_keep_size = 64
listen_addresses = '*'
EOF

psql -U postgres -c "CREATE ROLE replicator WITH REPLICATION LOGIN PASSWORD 'replicator';"
