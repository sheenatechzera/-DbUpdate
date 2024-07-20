# Define the path to the portable Git executable
$gitExecutable = Join-Path -Path $PSScriptRoot -ChildPath "bin\Debug\tools\git\bin\git.exe"

if (-not (Test-Path -Path $gitExecutable)) {
    Write-Error "Git executable not found at $gitExecutable"
    exit 1
}

try {
    # Get the current commit hash using the portable Git executable
    $commitHash = & "$gitExecutable" rev-parse --short HEAD

    if ($commitHash -eq $null) {
        throw "Failed to retrieve Git commit hash."
    }

    # Determine the output path (bin directory)
    $configuration = $env:Configuration -replace '"', ''
    $outputPath = Join-Path -Path $PSScriptRoot -ChildPath "bin\Debug\gitversion.txt"

    # Ensure the output directory exists
    $outputDir = Split-Path -Path $outputPath -Parent
    if (-not (Test-Path -Path $outputDir)) {
        New-Item -ItemType Directory -Path $outputDir -Force
    }

    # Write the commit hash to the file
    $commitHash > $outputPath

    Write-Output "Git version written to $outputPath"
} catch {
    Write-Error "An error occurred: $_"
    exit 1
}