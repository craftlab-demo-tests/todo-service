# generate

docker run --rm -v "${PWD}:/local" openapitools/openapi-generator-cli generate \
    -i /local/openapi.yaml \
    -g aspnetcore \
    -o /local/server