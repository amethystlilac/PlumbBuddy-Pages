param(
    [string]$publishDir
)

$indexFile = "$publishDir\wwwroot\index.html"
$content = Get-Content $indexFile
$timestamp = Get-Date -Format 'yyyyMMddHHmmss'

# Replace or append the version in the published index.html
$newContent = $content -replace 'blazor.webassembly.js(\?v=\d+)?', "blazor.webassembly.js?v=$timestamp"

# Write the updated content back to the published file
$newContent | Set-Content $indexFile
