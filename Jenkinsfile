pipeline {
	agent any
	triggers {
		pollSCM("* * * * *")
		//cron("* * * * *")
	}
	stages
	{
		stage("build")
		{
			steps
			{
				sh "dotnet restore"
				sh "dotnet build IdleGame/Web/home.html"
				echo "build complete"}
			}

			stage ("test")
			{
				steps
				{
					dir("tests") //project folder name
					{
						sh "dotnet add package coverlet.collector"
						sh "dotnet test --collect:'XPlat Code Coverage'"
					}
				}
				post
				{
					success{
						archiveArtifacts "Test/TestResults/*/coverage.cobertura.xml" //prolly change file directory here?
						publishCoverage adapters: [istanbulCoberturaAdapter(path: 'Tests/TestResults/*/coverage.cobertura.xml',
									  [[failUnhealthy: true, thresholdTarget: 'Conditional', unhealthyThreshold: 80.0,
									    unstableThreshold: 50.0]])], checksName: '', sourceFileResolver: sourceFiles('never store')
					}
				}
			}

			stage("deploy")
			{
				steps
				{
					echo 'deployment started'

				}
			}
		}
	}
