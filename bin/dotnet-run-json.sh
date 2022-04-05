#! /usr/bin/env bash

function cleanup() {
    rm -f doppler.json
}

# 3. Call cleanup when process exits
trap cleanup EXIT

# 1. Generate JSON
doppler secrets download --name-transformer dotnet --no-file > doppler.json

# 2. Run application
dotnet run