<template>
  <q-page class="q-h-screen flex flex-center">
    <!-- Header -->
    <q-header elevated>
      <q-toolbar>
        <q-btn
          flat
          dense
          @click="$router.push('/about')"
        >
          About
        </q-btn>
        <q-space />
        <q-btn
          flat
          dense
          @click="openDialog"
        >
          Open Dialog
        </q-btn>
      </q-toolbar>
    </q-header>

    <!-- Content Section -->
    <q-page-container>
      <div class="q-pa-md text-h6 text-center">
        <h1>Welcome to My Enhanced Quasar App!</h1>
        <p>This is a more customized main page.</p>

        <!-- Additional Content -->
        <q-card class="q-mt-md">
          <q-card-section>
            <h2>Features:</h2>
            <ul>
              <li>Beautiful Quasar UI components</li>
              <li>Customized main page</li>
              <li>Routing to About page</li>
              <li>Custom Dialog</li>
            </ul>
          </q-card-section>
        </q-card>
      </div>
    </q-page-container>

    <!-- Custom Dialog -->
    <q-dialog v-model="dialogVisible">
      <q-card>
        <q-card-section>
          <h4 class="q-mb-md">Custom Dialog</h4>
          <p>This is a custom dialog content.</p>
        </q-card-section>
        <q-card-actions align="right">
          <q-btn label="Close" color="primary" @click="closeDialog" />
        </q-card-actions>
      </q-card>
    </q-dialog>
  </q-page>
</template>

<script>
export default {
  data() {
    return {
      dialogVisible: false,
    };
  },
  methods: {
    openDialog() {
      this.dialogVisible = true;
    },
    closeDialog() {
      this.dialogVisible = false;
    },
  },
};
</script>

<style scoped>
/* Add your custom styles here */
.q-mt-md {
  margin-top: 20px;
}
</style>
