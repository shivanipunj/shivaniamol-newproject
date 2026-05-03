pipeline {
    agent any

    environment {
        DOCKER_IMAGE = "myapp-image"
    }

    stages {

        stage('Build .NET App') {
            steps {
                dir('src/myapp') {
                    bat 'dotnet restore'
                    bat 'dotnet build'
                }
            }
        }
       stage('Publish App') {
            steps {
                dir('src/myapp') {
                    bat 'dotnet publish -c Release -o publish'
                }
            }
        }
        stage('Build Docker Image') {
            steps {
                bat 'docker build -t $DOCKER_IMAGE .'
            }
        }

        stage('Run Container') {
            steps {
                bat 'docker run -d -p 8080:80 $DOCKER_IMAGE'
            }
        }
    }
}
