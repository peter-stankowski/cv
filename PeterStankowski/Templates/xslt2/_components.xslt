<xsl:stylesheet version="2.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
  xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
  <xsl:template match="avatar">
    <img class="m-auto">
      <xsl:attribute name="src">
        <xsl:value-of select="@src"/>
      </xsl:attribute>
    </img>
  </xsl:template>

  <xsl:template match="badges">
    <xsl:apply-templates select="b" >
      <xsl:with-param name="type" select="@type"></xsl:with-param>
    </xsl:apply-templates>
  </xsl:template>
  <xsl:template match="b">
    <xsl:param name="type"/>
    <span>
      <xsl:attribute name="class">
        <xsl:value-of select="concat('p-2 m-1 badge badge-', $type)"/> 
      </xsl:attribute>
      <xsl:value-of select="."/>
    </span>
  </xsl:template>


  <xsl:template match="links">
    <xsl:apply-templates select="l">
      <xsl:with-param name="type" select="@type"></xsl:with-param>
    </xsl:apply-templates>
  </xsl:template>
  <xsl:template match="links/l">
    <xsl:param name="type"/>
    <a>
      <xsl:attribute name="href">
        <xsl:value-of select="@href"/>
      </xsl:attribute>
      <xsl:attribute name="class">
        <xsl:value-of select="concat('d-block text-left btn btn-link btn-',$type)"/>
      </xsl:attribute>
      <xsl:value-of select="."/>
    </a>
  </xsl:template>

  <xsl:template match="list">
    <ul class="list-group list-group-flush mb-3 mt-3">
      <xsl:apply-templates select="l">
        <xsl:with-param name="type" select="@type"></xsl:with-param>
      </xsl:apply-templates>
    </ul>
  </xsl:template>
  <xsl:template match="l">
    <xsl:param name="type"/>
    <li>
      <xsl:attribute name="class">
        <xsl:value-of select="concat('m-0 pl-0 list-group-item list-group-item-',$type)"/>
      </xsl:attribute>
      <xsl:value-of select="."/>
    </li>
  </xsl:template>

  <xsl:template match="title">
    <xsl:param name="fa"/>
    
    <h3>
      <xsl:attribute name="class">
        <xsl:choose>
          <xsl:when test="@fa != ''">mb-4 mt-3 text-title with-fa</xsl:when>
          <xsl:otherwise>mb-4 mt-3 text-title</xsl:otherwise>
        </xsl:choose>
      </xsl:attribute>
      <xsl:value-of select="."/>
      <xsl:if test="@fa != ''">
        <i>
          <xsl:attribute name="class">
            <xsl:value-of select="concat('fa fa-', @fa)"/>
          </xsl:attribute>
        </i>
      </xsl:if>

      
    </h3>
  </xsl:template>
  <xsl:template match="splitsection/title">
    <h4 class="mb-0 text-title-10">
      <xsl:value-of select="."/>
    </h4>
  </xsl:template>
  <xsl:template match="subtitle">
    <h6 class="text-subtitle">
      <xsl:value-of select="."/>
    </h6>
  </xsl:template>
  <xsl:template match="splitsection/subtitle">
    <h5>
      <small class="text-muted">
        <xsl:value-of select="."/>
      </small>
    </h5>
  </xsl:template>
  <xsl:template match="content/card/section/subtitle">
    <h6 class="lead">
      <xsl:value-of select="."/>
    </h6>
  </xsl:template>
  <xsl:template match="text">
    <p>
      <xsl:value-of select="."/>
    </p>
  </xsl:template>
  <xsl:template match="date">
    <span class="badge badge-light d-block p-4 mb-3">
      <xsl:value-of select="."/>
    </span>

  </xsl:template>
  <xsl:template match="icon">
    <xsl:param name="fa"/>
    <i>
      <xsl:attribute name="class">
        <xsl:value-of select="concat('fa fa-', @fa)"/>
      </xsl:attribute>
      <xsl:value-of select="."/>
    </i>
  </xsl:template>

  
</xsl:stylesheet>

