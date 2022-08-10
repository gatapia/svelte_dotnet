# .Net Svelte SPA Project Template

This project is a bare-bones project template to quickly get started with the following tech stack:
- Svelte 
- SvelteKit for routing
- Carbon Design System 
- C# / .Net 6.0
- NUnit
- IIS Hosted (requires [IIS URL Rewrite Module](https://www.iis.net/downloads/microsoft/url-rewrite)

# Getting Started
- Clone this repository: `git clone https://github.com/gatapia/svelte_dotnet_template.git`
- Edit `svelte.config.js` and replace `<project-directory>` with the IIS virtual directory/application name
- Run `npm install` in the `web` directory
- Run `release.bat` in the root directory, this will create the `release` directory which can be deployed in IIS
- Set up a virtual directory/application in IIS pointing to the created `release` directory
- Develop by running the `srv` project on IIS Express (`Ctrl + F5` in Visual Studio) and running `npm run dev` in the dev directory

# Important Commands:
- `release.bat` updates the `release` directory for IIS deployment.  Note: IIS locks this directory, so for any further 
  releases you will need to stop IIS.  This is easily done by killing the `w3wp.exe` process
- `release_web.bat` updates the svelte code in the `release\wwwroot` directory
- Run dev server: `npm run dev` (in `web` directory)

# Important Links:
- [Svelte](https://svelte.dev/docs)
- [SvelteKit](https://kit.svelte.dev/docs/introduction)
- [Carbon Design System - Icons](https://www.carbondesignsystem.com/guidelines/icons/library/)
- [Carbon Design System - Svelte Components](https://carbon-components-svelte.onrender.com/)
- [Carbon Design System - Svelte Github](https://github.com/carbon-design-system/carbon-components-svelte)
- [Carbon Design System - Main Docs](https://www.carbondesignsystem.com/)
