Task("Restore")
.Does(() => {
  DotNetCoreRestore("**/*.sln");
});