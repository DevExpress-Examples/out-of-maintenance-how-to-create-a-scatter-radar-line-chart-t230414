<%@ Page Title="Home Page" Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="ScatterRadarLine._Default" %>

<%@ Register Assembly="DevExpress.XtraCharts.v15.1.Web, Version=15.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraCharts.Web" TagPrefix="dxchartsui" %>
<%@ Register Assembly="DevExpress.XtraCharts.v15.1, Version=15.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraCharts" TagPrefix="cc1" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <dxchartsui:WebChartControl ID="WebChartControl1" runat="server" CrosshairEnabled="True" Height="351px" Width="552px">
        <diagramserializable>
            <cc1:RadarDiagram RotationDirection="Clockwise" StartAngleInDegrees="5">
            </cc1:RadarDiagram>
        </diagramserializable>
        <legend visibility="False"></legend>
        <seriesserializable>
            <cc1:Series Name="Series 1">
                <points>
                    <cc1:SeriesPoint ArgumentSerializable="2.58308729295161" Values="2.92389013581495">
                    </cc1:SeriesPoint>
                    <cc1:SeriesPoint ArgumentSerializable="2.72271363311115" Values="1.60362130049876">
                    </cc1:SeriesPoint>
                    <cc1:SeriesPoint ArgumentSerializable="2.8623399732707" Values="0.916511826809461">
                    </cc1:SeriesPoint>
                    <cc1:SeriesPoint ArgumentSerializable="3.00196631343025" Values="0.426951214001806">
                    </cc1:SeriesPoint>
                    <cc1:SeriesPoint ArgumentSerializable="3.14159265358979" Values="3.67381906146713E-16">
                    </cc1:SeriesPoint>
                    <cc1:SeriesPoint ArgumentSerializable="0.15707963267949" Values="0.479172332020966">
                    </cc1:SeriesPoint>
                    <cc1:SeriesPoint ArgumentSerializable="0.36651914291880" Values="1.16748565197914">
                    </cc1:SeriesPoint>
                    <cc1:SeriesPoint ArgumentSerializable="0.575958653158129" Values="1.82356171354251">
                    </cc1:SeriesPoint>
                    <cc1:SeriesPoint ArgumentSerializable="0.785398163397448" Values="2.12132034355964">
                    </cc1:SeriesPoint>
                    <cc1:SeriesPoint ArgumentSerializable="0.994837673636768" Values="1.82356171354251">
                    </cc1:SeriesPoint>
                    <cc1:SeriesPoint ArgumentSerializable="1.20427718387609" Values="1.16748565197914">
                    </cc1:SeriesPoint>
                    <cc1:SeriesPoint ArgumentSerializable="1.41371669411541" Values="0.479172332020967">
                    </cc1:SeriesPoint>
                    <cc1:SeriesPoint ArgumentSerializable="4.74729556542458" Values="0.10483062990165">
                    </cc1:SeriesPoint>
                    <cc1:SeriesPoint ArgumentSerializable="5.02654824574367" Values="1.06132878657975">
                    </cc1:SeriesPoint>
                    <cc1:SeriesPoint ArgumentSerializable="5.23598775598299" Values="2.47662710943896">
                    </cc1:SeriesPoint>
                    <cc1:SeriesPoint ArgumentSerializable="5.27089434102288" Values="2.92389013581494">
                    </cc1:SeriesPoint>
                </points>
                <viewserializable>
                    <cc1:ScatterRadarLineSeriesView>
                        <linestyle dashstyle="DashDot" />
                    </cc1:ScatterRadarLineSeriesView>
                </viewserializable>
            </cc1:Series>
        </seriesserializable>
        <seriestemplate>
            <viewserializable>
                <cc1:ScatterRadarLineSeriesView>
                </cc1:ScatterRadarLineSeriesView>
            </viewserializable>
        </seriestemplate>
        <titles>
            <cc1:ChartTitle Text="Scatter Radar Line Chart" />
        </titles>
    </dxchartsui:WebChartControl>
</asp:Content>