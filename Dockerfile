FROM jenkins/jenkins:lts

USER root

RUN apt-get update && \
    apt-get upgrade -y && \
    apt-get install ca-certificates curl gnupg lsb-release -y && \
    mkdir -p /etc/apt/keyrings && \
    curl -fsSL https://download.docker.com/linux/debian/gpg | gpg --dearmor -o /etc/apt/keyrings/docker.gpg && \
    echo "deb [arch=$(dpkg --print-architecture) signed-by=/etc/apt/keyrings/docker.gpg] https://download.docker.com/linux/debian $(lsb_release -cs) stable" | tee /etc/apt/sources.list.d/docker.list > /dev/null && \
    apt-get update && \
    apt-get install docker-ce-cli docker-compose-plugin -y && \
    apt-get clean

USER jenkins