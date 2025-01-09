docker build -f .\DockerBuildReproSample\Dockerfile -t isolatedrepro .
func kubernetes deploy --image-name isolatedrepro:latest --dry-run --name repro