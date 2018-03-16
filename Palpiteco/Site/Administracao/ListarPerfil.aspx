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
                    
                    location.reload("false");
                    //$(this).closest('tr').remove();
                    alert("Perfil excluído com sucesso!");
                },
                error: function (e) {
                    //HideLoading();
                    //ShowModalAviso("Aviso", "Erro:" + e.error);
                    alert("Erro ao excluir o Perfil!");
                }
            });
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
                    ShowModalAviso("Aviso", "Erro:" + e.error);
                }
            });
        }

        //function actionFormatter(value, row, index) {
        //    return [
        //        '<a class="like" href="javascript:void(0)" title="Like">',
        //        '<i class="glyphicon glyphicon-heart"></i>',
        //        '</a>',
        //        '<a class="edit ml10" href="javascript:void(0)" title="Edit">',
        //        '<i class="glyphicon glyphicon-edit"></i>',
        //        '</a>',
        //        '<a class="remove ml10" href="javascript:void(0)" title="Remove">',
        //        '<i class="glyphicon glyphicon-remove"></i>',
        //        '</a>'
        //    ].join('');
        //}
        //window.actionEvents = {
        //    'click.like': function (e, value, row, index) {
        //        alert('You click like icon, row: ' + JSON.stringify(row));
        //        console.log(value, row, index);
        //    },
        //    'click.edit': function (e, value, row, index) {
        //        alert('You click edit icon, row: ' + JSON.stringify(row));
        //        console.log(value, row, index);
        //    },
        //    'click.remove': function (e, value, row, index) {
        //        alert('You click remove icon, row: ' + JSON.stringify(row));
        //        console.log(value, row, index);
        //    }
        //};
    </script>
    <br />
    <div data-form="ui-body-a" class="ui-body ui-body-a ui-corner-all" id="divTblPerfis">
        <article id="" class="entry widget">
            <h2 class="section-title">
                <span>Lista de Perfis</span>
            </h2>
            <table id="tablePerfil" class="table-bordered dataTable stripe table-stripe">
                <thead>
                    <tr>

                        <th>Id</th>
                        <th>Nome</th>
                        <th>Acoes</th>
                        <%-- <th data-field="action" data-formatter="actionFormatter" data-events="actionEvents">Ações</th>--%>
                    </tr>
                </thead>
            </table>
        </article>
    </div>

  <button type="button" class="btn btn-info btn-lg" data-toggle="modal" data-target="#myModal">Open Modal</button>

  <!-- Modal -->
  <div class="modal fade" id="modal" role="dialog">
    <div class="modal-dialog">
    
      <!-- Modal content-->
      <div class="modal-content">
        <div class="modal-header">
          <button type="button" class="close" data-dismiss="modal">&times;</button>
          <h4 class="modal-title">Modal Header</h4>
        </div>
        <div class="modal-body">
          <p>Some text in the modal.</p>
        </div>
        <div class="modal-footer">
          <button type="button" class="btn btn-info btn-lg" data-dismiss="modal">Close</button>
        </div>
      </div>
      </div>
    </div>
</asp:Content>
