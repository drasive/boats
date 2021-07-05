<template>
  <v-app>
    <v-app-bar
      app
      color="primary"
      dark
    >
      <div class="d-flex align-center">
        <v-img
          alt="Logo"
          class="shrink mr-2"
          contain
          src="./assets/boat.svg"
          transition="scale-transition"
          width="40"
        />

        <h1>Boats WebApp</h1>
      </div>
    </v-app-bar>

    <v-main class="mt-3 mb-4">
      <BoatsOverview />
    </v-main>

    <v-card>
      <v-footer
        v-bind="localAttrs"
        :padless="padless"
      >
        <v-card
          flat
          tile
          width="100%"
          class="primary lighten-1 text-center"
        >
          <v-card-text class="white--text">
            <div>Icon made by <a href="" title="turkkub" class="white--text">turkkub</a> from <a href="https://www.flaticon.com/" title="Flaticon" class="white--text">www.flaticon.com</a></div>
          </v-card-text>

          <v-divider></v-divider>

          <v-card-text class="white--text">
            <strong>Dimitri Vranken</strong> {{ new Date().getFullYear() }}
          </v-card-text>
        </v-card>
      </v-footer>
    </v-card>
  </v-app>
</template>

<script>
import BoatsOverview from './components/BoatsOverview';

export default {
  name: 'App',

  components: {
    BoatsOverview,
  },

  data: () => ({
    //
  }),
};
</script>
