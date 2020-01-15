<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
  xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
  <xsl:template match="section">
    <xsl:param name="divider"/>

    <xsl:apply-templates select="title | subtitle | text | badges | badgeList | links"/>
    <xsl:if test="@divider = 'true'">
      <hr />
    </xsl:if>
  </xsl:template>

</xsl:stylesheet>

