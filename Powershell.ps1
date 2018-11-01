#Powershell

#Define variables
$centralUSResources = {}

#Get-AzureRmResourceGroup 'RsgDEVCEMetrica'

$centralUSResources = Get-AzureRmResource | Where-Object Location -eq 'CentralUS'
