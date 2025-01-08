docker build -f .\Az.Functions.MetadataToJson.Console\Dockerfile -t horselessisolatedfuncs:base .
docker tag horselessisolatedfuncs:base thehorselessnewspaper/horselessisolatedfuncs:base
docker push thehorselessnewspaper/horselessisolatedfuncs:base