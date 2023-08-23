# Framework48-Integration-Pipeline
POC de Deploy de aplicacion .Net Framework 4.8

nuget restore C:\Users\raulp\Documents\GitHub\Tresvi\Framework48-Integration-Pipeline

#Linea para compilacion de la solucion completa (sin restauracion previa de paquetes nuget)
msbuild /m /p:Configuration=Release C:\Users\raulp\Documents\GitHub\Tresvi\Framework48-Integration-Pipeline

#Linea para generar un Package con archivo de instalacion de msdeploy.exe. Genera tambien Una Carpeta con la salida del publish y otra con la salida empaquetada y empaquetada comprimida
msbuild C:\Users\raulp\Documents\GitHub\Tresvi\Framework48-Integration-Pipeline\WebAPI\WebAPI.csproj /p:Configuration=Release /p:Platform=AnyCPU /t:Package /p:OutputPath=C:\Temp\Publish

#Solo compila binarios, no crea web.config
MSBuild C:\Users\raulp\Documents\GitHub\Tresvi\Framework48-Integration-Pipeline\WebAPI\WebAPI.csproj /p:DeployOnBuild=true /p:PublishProfile=WebDeploy /p:CreatePackageOnPublish=True  /p:VisualStudioVersion=11.0 /p:OutputPath=C:\Temp\Publish /t:Package


#Linea para compilacion y publish
msbuild /m /p:Configuration=Release C:\Users\raulp\Documents\GitHub\Tresvi\Framework48-Integration-Pipeline


msbuild C:\Users\raulp\Documents\GitHub\Tresvi\Framework48-Integration-Pipeline\WebAPI\WebAPI.csproj /p:Configuration=Release /p:Platform=AnyCPU /t:Publish /p:PublishDir=C:\Temp\Publish /p:PublishProfile=
