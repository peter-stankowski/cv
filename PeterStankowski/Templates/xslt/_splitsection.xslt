<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
  xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
  <xsl:template match="splitsection">
    <xsl:param name="divider"/>

    <div class="row">
      <div class="col-lg-3 col-md-3 col-xl-3 text-center text-sm-left">
        <xsl:apply-templates select="date"/>
      </div>
      <div class="col-lg-9 col-md-9 col-xl-9">
        <xsl:apply-templates select="title"/>
        <xsl:apply-templates select="subtitle"/>

        <xsl:apply-templates select="text | badges | links | list"/>
      </div>
    </div>
    
    <xsl:if test="@divider = 'true'">
      <hr class="mb-5 mt-5" />
    </xsl:if>
  </xsl:template>

</xsl:stylesheet>

