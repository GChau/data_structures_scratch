Playing around with C++ and Hello World in a Docker container.

Steps

1. Build the Docker image for Clang. \
    `docker build --rm -f Dockerfile.clang -t dockerclang:latest`
2. Build the Docker image for GCC. \
    `docker build --rm -f Dockerfile.gcc -t dockergcc:latest`
3. Run Clang container. \
    `docker run -it --rm dockerclang:latest` 
3. Run GCC container. \
    `docker run -it --rm dockergcc:latest` 

Source:

* https://devblogs.microsoft.com/cppblog/c-development-with-docker-containers-in-visual-studio-code/
* https://hub.docker.com/_/gcc?tab=tags&page=1&ordering=last_updated