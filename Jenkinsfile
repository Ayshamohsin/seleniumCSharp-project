pipeline {
    agent any

    environment {
        // You can define any environment variables here if needed
    }

    stages {
        stage('Checkout') {
            steps {
                // Checkout code from GitHub
                git url: 'https://github.com/Ayshamohsin/seleniumCSharp-project.git', branch: 'main'
            }
        }
        
        stage('Restore Dependencies') {
            steps {
                script {
                    // Restore dependencies using PowerShell on Windows
                    powershell 'dotnet restore'
                }
            }
        }

        stage('Build') {
            steps {
                script {
                    // Build the project using PowerShell on Windows
                    powershell 'dotnet build'
                }
            }
        }

        stage('Test') {
            steps {
                script {
                    // Run tests using PowerShell on Windows
                    powershell 'dotnet test'
                }
            }
        }
        
        stage('Publish') {
            steps {
                script {
                    // Optionally publish the build (if necessary)
                    powershell 'dotnet publish'
                }
            }
        }
    }

    post {
        success {
            echo 'Build succeeded!'
        }
        failure {
            echo 'Build failed!'
        }
    }
}
