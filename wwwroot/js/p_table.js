function drawTable() {
    $(document).ready(function () {
        $('#pTable').DataTable({
            "responsive": true,
            "ordering": true,
            "processing": true,
            "orderMulti": false,
            "ajax": {
                "url": "/Content/GetContentList",
                "type": "GET",
                "datatype": "json",
                'dataSrc': '',
            },
            //   data:[
            //     new Anime("Kimetsu no Yaiba", "From 2019","Drama, Action, Adventure, Dark Fantasy","Beginners/Fans"),
            //     new Anime("Re:Zero -Starting Life in Another World", "From 2016","Isekai, Adventure, Dark Fantasy, Time loop",
            //     "Fans/Freaks")
            //   ],
            pageLength: 0,
            lengthMenu: [2, 3, 5, 10],
            columns: [
                {
                    data: 'photo',
                    name: 'photo',
                    render: function (data, type, row) {
                        return '<img src="/photos/' + data + '" alt="Anime icon" class="img-circle" width="40" height="40">'
                    }
                },
                { data: 'name', name: 'name' },
                { data: 'airDate', name: 'airDate' },
                { data: 'genre', name: 'genre' },
                { data: 'recommendedFor', name: 'genre' },
                // {data: 'review', 
                //     render : {
                //     _: 'rating',
                //     sort: 'nb_voting'
                // },}
                {
                    data: 'rating', name: 'review',
                    /*  render: function (data, type, row) {
                          // some decision statement
                          // return data.rating;
                          //return "Rating = " + data.rating + " (Nb voting = " + data.nb_voting + ")";
                          // var dataSplit = data.rating.split('.',1);
                          // return dataSplit;
                      }*/
                },
                {
                    data: 'link', name: 'link',
                    render: function (data, type, row) {
                        return '<form action="' + data + '"> <button type="submit" class="btn btn-primary"><i class="fas fa-angle-double-right"></i></button> </form>';
                    }
                }
            ],
            "columnDefs": [{
                targets: [0],
                // visible: false,
                // searchable: false,
                orderable: false,
            },
            {
                targets: [4],
                searchable: false,
            }
            ]
        });
    });
}

drawTable();
