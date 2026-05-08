pipeline {
    agent any

    environment {
        DOCKER_IMAGE = "myapp-image"
    }

    stages {
stage('Check Dotnet') {
    steps {
        bat 'dotnet --info'
    }
}
       stage('Build .NET App') {
            steps {
                bat 'dotnet restore src\\myapp'
                bat 'dotnet build src\\myapp'
            }
        }

        stage('Publish App') {
            steps {
                bat 'dotnet publish src\\myapp -c Release -o publish'
            }
        }
        stage('Build Docker Image') {
            steps {
                bat 'docker build -t %DOCKER_IMAGE% .'
            }
        }

        stage('Run Container') {
            steps {
                bat 'docker run -d -p 8081:80 %DOCKER_IMAGE%'
            }
        }
       // stage('Clean') {
        // steps {
        //     deleteDir()
        // }
//}
    }
}
