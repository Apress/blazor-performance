


## Lazy Loading

When your Blazor WebAssembly application gets loaded by the browser, normally all assemblies 
are downloaded, even if they are not immediatly needed. 
This can result in a noticable delay before the first page is rendered.

With lazy loading you can postpone downloading the assemblies that are only needed for a
specific page until the user navigates to that page.

Let us look at an example:



