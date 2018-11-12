
$PSVersionTable.PSVersion

Write-Host "HOLA"
Write-Verbose "HOLA Verbose"


Get-Help 'ResourceGroup'

$rsg =  Get-AzureRmResourceGroup -Name 'RsgDEV1CEMetrica' -ErrorAction SilentlyContinue
if (-not $rsg)
{
    Write-Host "Doesnt exist"
}

Get-AzureRmVMSize -Location 'northeurope'
Get-AzureRmVM -ResourceGroupName 'RsgDEVCEMetrica' -Name 'SDAZMETSE'
