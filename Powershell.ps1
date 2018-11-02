#Powershell

#Define variables
$centralUSResources = {}

#Get-AzureRmResourceGroup 'RsgDEVCEMetrica'

$centralUSResources = Get-AzureRmResource | Where-Object Location -eq 'CentralUS'

$Menu = 'RsgDEVCEMetrica', 'RsgSelCEMetrica'

$ApplicationChoices = $Menu | Out-GridView -OutputMode Single -Title 'Select application to deploy , and click OK.'

# $ApplicationChoices = Out-GridView -InputObject $Menu -OutputMode Single -Title 'Select application to deploy , and click OK.'
