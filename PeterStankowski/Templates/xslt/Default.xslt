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


  <!--root-->
  <xsl:template match="layout">
    
    <div class="layout container-fluid">
      <xsl:apply-templates select="stickynavbar"></xsl:apply-templates>
      

      <div class="row">
        <div class="sidebar pt-3 pb-3">
          <!--<xsl:for-each select="msxsl:node-set($array)/item">
            <h1>
              <xsl:value-of select="."/>
            </h1>
          </xsl:for-each>-->
          
          <span class="layout-divider bg-primary">
            <i class="fa fa-compress" aria-hidden="true"></i>
          </span>
          <xsl:apply-templates select="sidebar"></xsl:apply-templates>
        </div>

        <main class="pb-3 pt-3">
          <!--<nav class="navbar fixed-top navbar-light bg-light">
            <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
              <i class="fa fa-bars"></i>
            </a>
            <div class="dropdown-menu" aria-labelledby="navbarDropdown">
              <a class="dropdown-item" href="#">Action</a>
              <a class="dropdown-item" href="#">Another action</a>
              <div class="dropdown-divider"></div>
              <a class="dropdown-item" href="#">Something else here</a>
            </div>
          </nav>-->
          <xsl:apply-templates select="content"></xsl:apply-templates>
        </main>
      </div>
    </div>
  </xsl:template>

  <!--sidebar / content-->
  <xsl:template match="sidebar">
    <xsl:apply-templates select="card">
      <xsl:with-param name="plain" select="'false'" />
    </xsl:apply-templates>
  </xsl:template>
  <xsl:template match="content">
    <xsl:apply-templates select="card">
      <xsl:with-param name="plain" select="'true'" />
    </xsl:apply-templates>
  </xsl:template>

</xsl:stylesheet>
