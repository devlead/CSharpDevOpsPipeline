---?image=assets/img/swetugg_butterfly_text_bw.png&size=50% auto&position=50px 50px&opacity=50
@title[Azure DevOps Pipelines as code using C#]
Azure DevOps Pipelines
</br>
as code using C# @fa[rocket text-orange]

@snap[south-east text-08]
@fa[twitter] @fa[medium] @fa[github] <a style='text-decoration: none; color: white;' href='https://twitter.com/devlead'>@devlead</a> - Mattias Karlsson
@snapend
---
@title[Setting the stage]
---
@title[Mattias Karlsson]
@snap[east]
# @fa[user text-gray] 
@snapend

@snap[west span-83]
@ul[none]
- @fa[briefcase] Partner & Sr. architect at WCOM @note[a Microsoft partner located in Gothenburg, Sweden.]
- @fa[cloud] Microsoft Azure MVP @note[Head in the cloud.]
- @fa[wrench] Microsoft Developer Technologies MVP @note[Still gets my hands dirty.]
- @fa[magic] OzCode Magician community @note[Passion for diagnosing and fixing broken code]
- @fa[code-fork] Open source  @note[Active in the open source community. Most know there for being one of the maintainers behind the Cake build system, which is now also part of the .NET foundation.].
- @emoji[family] Husband of 1, father of 2 @note[last but not least]
@ulend
@snapend
---
@title[Common pipeline]

@snap[west span-40 text-center]
@ul[process]
- @fa[cloud-download] Restore @note[Restore dependencies from i.e. NuGet]
- !
- @fa[cogs] Build
- !
- @fa[flask] Test
- !
- @fa[archive] Package
- !
- @fa[cloud-upload] Publish @note[Publish artifacts to i.e. NuGet]
@ulend
@snapend

@snap[midpoint span-10 fragment]
@fa[plus]
@snapend
---
