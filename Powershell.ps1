#Powershell

#PS version
$PSVersionTable.PSVersion

#Define variables
$centralUSResources = {}

#Get-AzureRmResourceGroup 'RsgDEVCEMetrica'

$centralUSResources = Get-AzureRmResource | Where-Object Location -eq 'CentralUS'

#Out-GridView

$Menu = 'RsgDEVCEMetrica', 'RsgSelCEMetrica'

$ApplicationChoices = $Menu | Out-GridView -OutputMode Single -Title 'Select application to deploy , and click OK.'

Switch ($ApplicationChoices)
{
    RsgDEVCEMetrica {
        Get-AzureRmResourceGroup -Name $ApplicationChoices
    }

    RsgSelCEMetrica {
        Get-AzureRmResourceGroup -Name $ApplicationChoices
    }
}

#Credential
$cred = Get-Credential -Message 'Enter your credentials'

#Write to console
$VerbosePreference.value__
Write-Verbose -Message "Searching the Application Event Log."
Write-Host $cred


