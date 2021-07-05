<template>
  <div>
    <h1 style="text-align: center;">Boat Overview</h1>
    <v-data-table
      :headers="headers"
      :items="elements"
      :options.sync="options"
      :hide-default-footer="true"
      :disable-pagination="true"
      :loading="loading"
      class="elevation-1"
    >

    </v-data-table>
  </div>
</template>

<script>
  import axios from "axios";
  export default {
    name: "DatatableComponent",
    data() {
      return {
        elements: [],
        loading: true,
        options: {},
        headers: [
          { text: "Name", value: "name" },
          { text: "Description", value: "description" },
        ],
      };
    },
    watch: {
      options: {
        handler() {
          this.loadData();
        },
      },
      deep: true,
    },
    methods: {
      loadData() {
        this.loading = true;
        axios
          .get(process.env.VUE_APP_API_URL + '/Boats')
          .then((response) => {
            this.loading = false;
            this.elements = response.data;
          })
          .catch((error) => {
            alert('An error occured while loading the bots. Make sure the API is reachable.\n\n' + error);
          });
      },
    },

    mounted() {
      this.loadData();
    },
  };
</script>
