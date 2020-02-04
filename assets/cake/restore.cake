Task("Restore")
.Does(() => {
  DotNetCoreRestore("src");
});