# CV ASP.NET MVC Project

XSLT template driven web project.

## Folder structure

* Services
  * XmlLayoutService : ILayoutService
* Templates
  * XSLT
  
## XSLT Template Parts

**Main Layout**
```
<layout>
  <sidebar>
  ...Cards
  </sidebar>
  <content>
  ...Cards
  </content>
</layout>
```

**Cards**
```
<card>
  <section>
  ...Components
  </section>
  <splitsection>
  ...Components
  </splitsection>
</card>
```

**Components**
```
<section>
  <title></title>
  <subtitle></subtitle>
  <text></text>
  <badges><b></b></badges>
</section>
```

```
<splitsection>
  <date></date>
  <title></title>
  <subtitle></subtitle>
  <text></text>
  <badges><b></b></badges>
</splitsection>
```

