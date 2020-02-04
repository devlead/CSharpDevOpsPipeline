Task("Package")
.Does(() => {
  DotNetCorePack("src",
    new DotNetCorePackSettings {
        OutputDirectory = "./artifacts"
    });
});