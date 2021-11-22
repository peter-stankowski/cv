<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
  xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
  <xsl:template match="stickynavbar">
    <div class="sticky-navbar fixed-right p-1">
      <xsl:apply-templates select="links"/>
    </div>
  </xsl:template>

</xsl:stylesheet>

