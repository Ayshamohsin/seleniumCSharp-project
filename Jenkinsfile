pipeline {
    agent any

    stages {
        stage('Build') {
            steps {
                echo ' Building the project'
                bat 'dotnet build'
            }
        }

        stage('Test') {
            steps {
                echo 'Running Selenium UI Tests (browser will open)'
                bat 'dotnet test --no-build --logger:trx'
            }
        }

        stage('Deploy') {
            steps {
                echo ' Deploy stage (optional)'
                // Add deploy steps here if needed
            }
        }
    }
}
