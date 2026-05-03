pipeline {
    agent any

    environment {
        DOCKER_IMAGE = "myapp-image"
    }

    stages {

        stage('Build .NET App') {
            steps {
                sh 'dotnet restore src/MyApp/MyApp.csproj'
                sh 'dotnet build src/MyApp/MyApp.csproj'
            }
        }

        stage('Publish App') {
            steps {
                sh 'dotnet publish src/MyApp/MyApp.csproj -c Release -o publish'
            }
        }

        stage('Build Docker Image') {
            steps {
                sh 'docker build -t $DOCKER_IMAGE .'
            }
        }

        stage('Run Container') {
            steps {
                sh 'docker run -d -p 8080:80 $DOCKER_IMAGE'
            }
        }
    }
}
