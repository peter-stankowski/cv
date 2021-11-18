# CV ASP.NET MVC Project

XSLT template driven web project. (old)

## Folder structure (old)

* Services
  * XmlLayout : ILayout
* Templates
  * XSLT
  * Razor (to do)

## To Do

* Finish Razor page render service
  
## XML Template Parts

**Main Layout**
```
<?xml version="1.0" encoding="utf-8" ?>
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
<card center="true/false">
 <avatar src=""></avatar>
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
<section divider="true/false">
 <title></title>
 <subtitle></subtitle>
 <text></text>
 <badges><b></b></badges>
</section>
```

```
<splitsection divider="true/false">
 <date></date>
 <title></title>
 <subtitle></subtitle>
 <text></text>
 <badges><b></b></badges>
</splitsection>
```

