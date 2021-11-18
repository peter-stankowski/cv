<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
  
  <!--content holders-->
  <xsl:import href="_card.xslt"/>
  <xsl:import href="_section.xslt"/>
  <xsl:import href="_splitsection.xslt"/>
  <xsl:import href="_stickynavbar.xslt"/>

  <!--components-->
  <xsl:import href="_components.xslt"/>

  <!--variables-->
  <!--<xsl:variable name="array">
    <item>
      <prop1>test</prop1>
      <prop2>test2</prop2>
    </item>
    <item>
      <prop1>test3333</prop1>
      <prop2>test44444</prop2>
    </item>
  </xsl:variable>-->

  <!--output-->
  <xsl:output method="html" indent="yes" />

  <!--parameters-->
  <xsl:variable name="progLanguages">
    <backend>
      <b>back 1</b>
      <b>back 2</b>
    </backend>
    <frontend>
      <b>front 1</b>
      <b>front 2</b>
    </frontend>
    <other>
      <b>other 1</b>
      <b>other 2</b>
    </other>
  </xsl:variable>

  <!--root-->
  <xsl:template match="layout">
    <div>
      <xsl:apply-templates select="*" />
    </div>
  </xsl:template>

  
  
</xsl:stylesheet>
