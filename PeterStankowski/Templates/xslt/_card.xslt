<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
  xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
  <xsl:template match="card">
    <xsl:param name="plain" select="@plain"></xsl:param>

    <div>
      <xsl:attribute name="class">
        <xsl:choose>
          <xsl:when test="$plain = 'false'">card m-auto p-3 border-0 shadow-sm</xsl:when>
          <xsl:when test="$plain = 'true'">card m-auto p-3 border-0</xsl:when>
        </xsl:choose>
      </xsl:attribute>
      <div class="text-center">
        <xsl:apply-templates select="avatar"></xsl:apply-templates>
      </div>

      <div class="card-body">
        <xsl:attribute name="class">
          <xsl:if test="@center = 'true'">text-center</xsl:if>
        </xsl:attribute>
        <xsl:apply-templates select="section | splitsection" >
          <xsl:with-param name="divider" select="@divider"></xsl:with-param>
        </xsl:apply-templates>
      </div>
    </div>
  </xsl:template>
</xsl:stylesheet>

