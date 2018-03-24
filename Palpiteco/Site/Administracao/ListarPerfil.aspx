<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="ListarPerfil.aspx.cs" Inherits="Palpiteco.Site.Administracao.ListarPerfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%--    <script src="../../js/DataTable/DataTables-1.10.16/js/jquery.dataTables.min.js"></script>
    <script src="../../js/DataTable/DataTables-1.10.16/js/dataTables.bootstrap.min.js"></script>--%>

    <link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/v/dt/dt-1.10.16/datatables.min.css" />
    <script type="text/javascript" src="https://cdn.datatables.net/v/dt/dt-1.10.16/datatables.min.js"></script>

    <link href="../../css/jquery.mobile.flatui.css" rel="stylesheet" />

    <script>
        $(document).ready(function () {
            BuscarPerfis();
        });


        function MontarTabela(perfis) {

            $(function () {
                $('#tablePerfil').bootstrapTable({
                    data: perfis
                });
            });
        }

        function ExcluirPerfil(id) {

            var p = new Object();
            p.id = id;
            $.ajax({
                type: "POST",
                url: 'ListarPerfil.aspx/ExcluirPerfil',
                data: JSON.stringify(p),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (data) {
                    
                    RemoverLinha(id);
                    //location.reload("false");
                    //$(this).closest('tr').remove();
                    alert("Excluido com sucesso!");
                },
                error: function (e) {
                    //HideLoading();
                    //ShowModalAviso("Aviso", "Erro:" + e.error);
                    alert("Erro ao excluir o Perfil!");
                }
            });
        }

        function RemoverLinha(id){
            $("#tablePerfil tr").remove((":contains('" + id + "')"));
        }

        function BuscarPerfis() {
            $.ajax({
                type: "POST",
                url: 'ListarPerfil.aspx/ListarPerfis',
                data: JSON.stringify(),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (data) {

                    var dados = jQuery.parseJSON(data.d);
                    $('#tablePerfil').DataTable({
                        "paging": true,
                        "order": [[0, "asc"]],
                        "info": true,
                        "autoWidth": false,
                        "bJQueryUI": true,
                        "processing": true,
                        "oLanguage": {
                            "sProcessing": "Processando...",
                            "sLengthMenu": "Mostrar _MENU_ registros",
                            "sZeroRecords": "Não foram encontrados resultados",
                            "sInfo": "Mostrando de _START_ até _END_ de _TOTAL_ registros",
                            "sInfoEmpty": "Mostrando de 0 até 0 de 0 registros",
                            "sInfoFiltered": "",
                            "sInfoPostFix": "",
                            "sSearch": "Buscar:",
                            "sUrl": "",
                            "oPaginate": {
                                "sFirst": "Primeiro",
                                "sPrevious": "Anterior",
                                "sNext": "Seguinte",
                                "sLast": "Último"
                            }
                        },
                        data: dados,
                        columns: [
                            { 'data': 'IdPerfil' },
                            { 'data': 'NomePerfil' },
                            { 'data': 'Acoes' }
                        ],
                        "columnDefs": [
                            {
                                //"targets": [2],
                                "visible": false,
                                "searchable": false
                            }, ]
                    });

                    //console.log(data.d);
                    // console.log(JSON.stringify(data.d));
                    //$('#tableteste').bootstrapTable('load', data.d);
                    //MontarTabela(data.d);
                },
                error: function (e) {
                    //HideLoading();
                    console.log(JSON.stringify(data.d));
                    ShowModalAviso("Aviso", "Erro:" + e.error);
                }
            });
        }

    </script>
    <br />
    <div data-form="ui-body-a" class="ui-body ui-body-a ui-corner-all ui-responsive" id="divTblPerfis">
        <article id="" class="entry widget">
            <h2 class="section-title">
                <span>Lista de Perfis</span>
            </h2>
            <table id="tablePerfil" class="table-bordered dataTable stripe table-stripe ui-responsive" style="align-items:center; text-align:center">
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Nome</th>
                        <th>Acoes</th>
                        <%-- <th data-field="action" data-formatter="actionFormatter" data-events="actionEvents">Ações</th>--%>
                    </tr>
                </thead>
            </table>
        </article>
    </div>

</asp:Content>
