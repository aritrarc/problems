#Powershell

#PS version
#$PSVersionTable.PSVersion
#exit;

#call ps
#& .\Powershell Scripts\PS.ps1
#exit;


#Define variables
#$centralUSResources = {}

#Get-AzureRmResourceGroup 'RsgDEVCEMetrica'

#$centralUSResources = Get-AzureRmResource | Where-Object Location -eq 'CentralUS'

#Out-GridView

# $Menu = 'RsgDEVCEMetrica', 'RsgSelCEMetrica'

# $ApplicationChoices = $Menu | Out-GridView -OutputMode Single -Title 'Select application to deploy , and click OK.'

# Switch ($ApplicationChoices)
# {
#     RsgDEVCEMetrica {
#         Get-AzureRmResourceGroup -Name $ApplicationChoices
#     }

#     RsgSelCEMetrica {
#         Get-AzureRmResourceGroup -Name $ApplicationChoices
#     }
# }

#Credential
# $cred = Get-Credential -Message 'Enter your credentials'

#Write to console
# $VerbosePreference.value__
# Write-Verbose -Message "Searching the Application Event Log."
# Write-Host $cred

#Get Public Ip
#Get-AzureRmPublicIpAddress -ResourceGroupName 'RsgDEVCEMetrica'

