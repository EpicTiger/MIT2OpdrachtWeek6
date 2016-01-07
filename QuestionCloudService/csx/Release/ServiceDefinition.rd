<?xml version="1.0" encoding="utf-8"?>
<serviceModel xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" name="QuestionCloudService" generation="1" functional="0" release="0" Id="600fef9e-efe8-4a71-aed3-eed2e5eccae8" dslVersion="1.2.0.0" xmlns="http://schemas.microsoft.com/dsltools/RDSM">
  <groups>
    <group name="QuestionCloudServiceGroup" generation="1" functional="0" release="0">
      <componentports>
        <inPort name="WCFServiceWebRole:Endpoint1" protocol="http">
          <inToChannel>
            <lBChannelMoniker name="/QuestionCloudService/QuestionCloudServiceGroup/LB:WCFServiceWebRole:Endpoint1" />
          </inToChannel>
        </inPort>
      </componentports>
      <settings>
        <aCS name="WCFServiceWebRole:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="">
          <maps>
            <mapMoniker name="/QuestionCloudService/QuestionCloudServiceGroup/MapWCFServiceWebRole:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </maps>
        </aCS>
        <aCS name="WCFServiceWebRoleInstances" defaultValue="[1,1,1]">
          <maps>
            <mapMoniker name="/QuestionCloudService/QuestionCloudServiceGroup/MapWCFServiceWebRoleInstances" />
          </maps>
        </aCS>
      </settings>
      <channels>
        <lBChannel name="LB:WCFServiceWebRole:Endpoint1">
          <toPorts>
            <inPortMoniker name="/QuestionCloudService/QuestionCloudServiceGroup/WCFServiceWebRole/Endpoint1" />
          </toPorts>
        </lBChannel>
      </channels>
      <maps>
        <map name="MapWCFServiceWebRole:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" kind="Identity">
          <setting>
            <aCSMoniker name="/QuestionCloudService/QuestionCloudServiceGroup/WCFServiceWebRole/Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </setting>
        </map>
        <map name="MapWCFServiceWebRoleInstances" kind="Identity">
          <setting>
            <sCSPolicyIDMoniker name="/QuestionCloudService/QuestionCloudServiceGroup/WCFServiceWebRoleInstances" />
          </setting>
        </map>
      </maps>
      <components>
        <groupHascomponents>
          <role name="WCFServiceWebRole" generation="1" functional="0" release="0" software="C:\Users\Marcel\Dropbox\MIT2\Opdrachten\Week 6\MIT2Questions\QuestionCloudService\csx\Release\roles\WCFServiceWebRole" entryPoint="base\x64\WaHostBootstrapper.exe" parameters="base\x64\WaIISHost.exe " memIndex="-1" hostingEnvironment="frontendadmin" hostingEnvironmentVersion="2">
            <componentports>
              <inPort name="Endpoint1" protocol="http" portRanges="80" />
            </componentports>
            <settings>
              <aCS name="Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="" />
              <aCS name="__ModelData" defaultValue="&lt;m role=&quot;WCFServiceWebRole&quot; xmlns=&quot;urn:azure:m:v1&quot;&gt;&lt;r name=&quot;WCFServiceWebRole&quot;&gt;&lt;e name=&quot;Endpoint1&quot; /&gt;&lt;/r&gt;&lt;/m&gt;" />
            </settings>
            <resourcereferences>
              <resourceReference name="DiagnosticStore" defaultAmount="[4096,4096,4096]" defaultSticky="true" kind="Directory" />
              <resourceReference name="EventStore" defaultAmount="[1000,1000,1000]" defaultSticky="false" kind="LogStore" />
            </resourcereferences>
          </role>
          <sCSPolicy>
            <sCSPolicyIDMoniker name="/QuestionCloudService/QuestionCloudServiceGroup/WCFServiceWebRoleInstances" />
            <sCSPolicyUpdateDomainMoniker name="/QuestionCloudService/QuestionCloudServiceGroup/WCFServiceWebRoleUpgradeDomains" />
            <sCSPolicyFaultDomainMoniker name="/QuestionCloudService/QuestionCloudServiceGroup/WCFServiceWebRoleFaultDomains" />
          </sCSPolicy>
        </groupHascomponents>
      </components>
      <sCSPolicy>
        <sCSPolicyUpdateDomain name="WCFServiceWebRoleUpgradeDomains" defaultPolicy="[5,5,5]" />
        <sCSPolicyFaultDomain name="WCFServiceWebRoleFaultDomains" defaultPolicy="[2,2,2]" />
        <sCSPolicyID name="WCFServiceWebRoleInstances" defaultPolicy="[1,1,1]" />
      </sCSPolicy>
    </group>
  </groups>
  <implements>
    <implementation Id="d6d057e7-ed74-49d3-b1ec-f2e08667a080" ref="Microsoft.RedDog.Contract\ServiceContract\QuestionCloudServiceContract@ServiceDefinition">
      <interfacereferences>
        <interfaceReference Id="c0881e8c-9b63-4832-9019-2510f6f9a1d2" ref="Microsoft.RedDog.Contract\Interface\WCFServiceWebRole:Endpoint1@ServiceDefinition">
          <inPort>
            <inPortMoniker name="/QuestionCloudService/QuestionCloudServiceGroup/WCFServiceWebRole:Endpoint1" />
          </inPort>
        </interfaceReference>
      </interfacereferences>
    </implementation>
  </implements>
</serviceModel>