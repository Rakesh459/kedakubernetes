{{- define "func-labels" -}}
app: func-app
env: {{ .Values.funcapp.env }}
{{- end -}}