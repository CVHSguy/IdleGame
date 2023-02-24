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
				sh "dotnet build IdleGame/IdleGame.csproj"
				echo "build complete"}
			}

			stage ("test")
			{
				steps
				{
					echo "test started"
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
