Task("Package")
.Does(() => {
  DotNetCorePack("**/*.sln",
    new DotNetCorePackSettings {
        OutputDirectory = "./artifacts"
    });
});